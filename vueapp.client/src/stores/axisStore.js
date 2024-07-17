import { defineStore } from 'pinia'

export const useAxisStore = defineStore('axis', {
    state: () => {
      return { xAxis: 0, yAxis: 0, circles: [] }
    },
  })