<script setup>
import { RouterView } from "vue-router";
</script>

<template>
  <header class="w-full h-[5%] flex px-4">
    <nav class="flex justify-center items-center">
      <div class="grid grid-rows-2 grid-cols-4 *:text-sm">
        <span>🔴</span>
        <span>🔵</span>
        <span>🟠</span>
        <span>🟡</span>
        <span>🟢</span>
        <span>🟣</span>
        <span>🟤</span>
        <span>⚫</span>
      </div>
    </nav>
  </header>
  <main class="w-full h-[95%]">
    <RouterView />
  </main>
  <footer></footer>
</template>

<style scoped></style>
