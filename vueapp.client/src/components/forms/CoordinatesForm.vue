<script setup>
import { useAxisStore } from '@/stores/axisStore'

// use axis store
const store = useAxisStore();

// constants for input min and max
const minCanvasX = 0;
const minCanvasY = 0;
const maxCanvasX = 600;
const maxCanvasY = 400;
</script>

<template>
  <div class="mb-4">
    <form
      @submit.prevent="$emit('onFormSubmit', store.xAxis, store.yAxis)"
      class="border border-black rounded-xl py-2 px-4 shadow-md
       *:rounded-full *:py-1 *:px-4 *:mr-4 [&>input]:border
        [&>input]:border-gray-500 
        [&>label]:text-lg [&>label]:font-bold"
    >
      <label for="xAxis">X:</label>
      <input type="number" id="xAxis" name="xAxis" placeholder="300.0" v-model="store.xAxis" :min="minCanvasX" :max="maxCanvasX">
      <label for="yAxis">Y:</label>
      <input type="number" id="yAxis" name="yAxis" placeholder="200.0" v-model="store.yAxis" :min="minCanvasY" :max="maxCanvasY" />
      <button
        type="submit"
        class="border rounded-full hover:border-gray-500 active:bg-gray-100 active:border-gray-200"
      >
        Create cirle
      </button>
    </form>
  </div>
</template>
