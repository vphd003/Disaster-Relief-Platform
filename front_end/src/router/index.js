import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import LoginView from '../views/LoginView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    // Redirect mặc định: mở app là vào login
    {
      path: '/',
      redirect: '/login'
    },
    // Trang đăng nhập
    {
      path: '/login',
      name: 'login',
      component: LoginView
    },
    // Trang chủ (sau khi đăng nhập xong)
    {
      path: '/home',
      name: 'home',
      component: HomeView,
    },
    {
      path: '/about',
      name: 'about',
      component: () => import('../views/AboutView.vue'),
    },
  ],
})

export default router
