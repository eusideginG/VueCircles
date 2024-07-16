<script setup>
import { ref, onMounted } from "vue";
import { useRoute } from "vue-router";
import { drawCircle } from "../../../services/draw/drawCirle";
import { postCircle } from "../../../services/requests/circleRequests";
import { useAxisStore } from "@/stores/axisStore";

// use axis store
const store = useAxisStore();
const route = useRoute();

// reactive values
const canvas = ref(null);

// expose the canvas to parent
defineExpose({ canvas });

// canvas click event listener
const onCanvasClick = (event) => {
  const rect = canvas.value.getBoundingClientRect();

  store.xAxis = Math.floor(event.clientX - rect.left);
  store.yAxis = Math.floor(event.clientY - rect.top);

  const { color, radius } = drawCircle(store.xAxis, store.yAxis, canvas.value);

  postCircle({
    dataId: route.params.id,
    time: new Date(Date.now()).toJSON(),
    xAxis: store.xAxis,
    yAxis: store.yAxis,
    color: color,
    diameter: radius * 2,
  });
};

// set canvas size and add event listener when the page is mounted
onMounted(() => {
  canvas.value.width = 600;
  canvas.value.height = 400;
  canvas.value.addEventListener("click", (e) => onCanvasClick(e));
});
</script>

<template>
  <div class="flex flex-col items-center">
    <canvas
      ref="canvas"
      class="border-2 border-black shadow-2xl rounded-lg"
    ></canvas>
  </div>
</template>
