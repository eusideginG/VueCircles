<script setup>
import { ref, onMounted } from "vue";
import { useRoute, useRouter } from "vue-router";
import DrawingCanvas from "@/components/canvas/DrawingCanvas.vue";
import CoordinatesForm from "@/components/forms/CoordinatesForm.vue";
import { useAxisStore } from "@/stores/axisStore";
import { drawCircle, drawFixedCircle } from "../../services/draw/drawCirle";
import { getById, postCircle } from "../../services/requests/circleRequests";

const route = useRoute();
const router = useRouter();
const store = useAxisStore();

// reference to canvas from DrawingCanvas component
const canvasRef = ref(null);

onMounted(async () => {
  // if the id url parameter is not (uuid - guid) redirect and generate a new one
  if (
    !/^[0-9a-fA-F]{8}\b-[0-9a-fA-F]{4}\b-[0-9a-fA-F]{4}\b-[0-9a-fA-F]{4}\b-[0-9a-fA-F]{12}$/gi.test(
      route.params.id
    )
  ) {
    router.replace(`/${crypto.randomUUID()}`);
  } else {
    store.circles = await getById(route.params.id);

    if (!Array.isArray(store.circles)) {
      store.circles = new Array();
    }

    if (!(store.circles.length > 0)) {
      console.log("No circles found");
    } else {
      store.circles.map((c) =>
        drawFixedCircle(canvasRef.value.canvas, {
          x: c.xAxis,
          y: c.yAxis,
          radius: c.diameter / 2,
          color: c.color,
        })
      );
    }
  }
});

// handling the form submit from CoordinatesForm component
const handleFormSubmit = (xAxis, yAxis) => {
  if (Array.isArray(store.circles)) {
    if (
      store.circles.filter(
        (c) => c.xAxis === store.xAxis && c.yAxis === store.yAxis
      ).length > 0
    ) {
      return;
    }
  }

  const { color, radius } = drawCircle(xAxis, yAxis, canvasRef.value.canvas);

  store.circles.push({
    dataId: route.params.id,
    time: new Date(Date.now()).toJSON(),
    xAxis: store.xAxis,
    yAxis: store.yAxis,
    color: color,
    diameter: radius * 2,
  });

  postCircle({
    dataId: route.params.id,
    time: new Date(Date.now()).toJSON(),
    xAxis: xAxis,
    yAxis: yAxis,
    color: color,
    diameter: radius * 2,
  });
};
</script>

<template>
  <div class="flex flex-col items-center">
    <div class="flex flex-col items-center">
      <CoordinatesForm @onFormSubmit="handleFormSubmit" />
      <DrawingCanvas ref="canvasRef" />
    </div>
  </div>
</template>
