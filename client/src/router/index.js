import Vue from 'vue'
import Router from 'vue-router'
import Vuelidate from 'vuelidate'
// import Terms from '@/components/Terms'

Vue.use(Router)
Vue.use(Vuelidate)

// Defining routes for web application
export default new Router({
  routes: [
    {
      // HomePage
      path: '/',
      name: 'Home',
      component: () => import('@/components/HomePage/Home')
    },
    {
      // Registration Page
      path: '/signup',
      name: 'Registration',
      component: () => import('@/components/Registration/Registration')
    },
    {
      // Chat Page
      path: '/chat',
      name: 'Chat',
      component: () => import('@/components/UserProfile/Chat')
    },
    {
      // UserManagement Page
      path: '/usermanagement',
      name: 'UserManagement',
      component: () => import('@/components/UserManagement/UserManagement')
    },
    {
      path: '/Review',
      name: 'Review',
      component: () => import('@/components/Reviews/Review')
    },
    {
      path: '/GetUserReview',
      name: 'GetUserReview',
      component: () => import('@/components/Reviews/GetUserReview')
    },
    {
      // UserProfile Page
      path: '/profile',
      name: 'UserProfile',
      component: () => import('@/components/UserProfile/ProfilePage')
    },
    {
      // Temporary Nav bar page
      path: '/temp',
      name: 'TempNav',
      component: () => import('@/components/TempNav')
    },
    {
      // Temporary Search bar page
      path: '/SearchBar',
      name: 'SearchBar',
      component: () => import('@/components/Search/SearchBar')
    },
    {
      // Catch All Error Page
      path: '*',
      name: '404NotFound',
      component: () => import('@/components/ErrorPage/404NotFound')

    }
  ]
})
