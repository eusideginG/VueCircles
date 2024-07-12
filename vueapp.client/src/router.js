import { createRouter, createWebHistory } from "vue-router";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      name: "home",
      redirect: `${crypto.randomUUID()}`,
      component: () => import("@/Views/HomeView.vue"),
    },
    {
      path: "/:id",
      name: "draw",
      component: () => import("@/Views/HomeView.vue"),
    },
    {
      path: "/:pathMatch(.*)*",
      name: "notFount",
      component: () => import("@/Views/404NotFound.vue"),
    },
  ],
});

export default router;
