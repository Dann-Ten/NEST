import Vue from "vue";
import VueRouter from "vue-router";
import Home from "../views/Home.vue";
import NProgress from "../assets/nprogress/nprogress";
Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home
  },
  {
    path: "/about",
    name: "About",
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () =>
      import(/* webpackChunkName: "about" */ "../views/About.vue")
    },
    {
        path: '/audit',
        name: 'Audit',
        component: () => import('../views/Audit.vue')
    },
    {
        path: '/Contact',
        name: 'Contact',
        component: () => import('../views/Contact.vue')
    },
    {
        path: '/Dash',
        name: 'Dash',
        component: () => import('../views/Dash.vue')
    },
    {
        path: '/EmergencyIsolation',
        name: 'EmergencyIsolation',
        component: () => import('../views/EmergencyIsolation.vue')
    },
    {
        path: '/Explore',
        name: 'Explore',
        component: () => import('../views/Explore.vue')
    },
    {
        path: '/Help',
        name: 'Help',
        component: () => import('../views/Help.vue')
    },
    {
        path: '/Isolate',
        name: 'Isolate',
        component: () => import('../views/Isolate.vue')
    },
    {
        path: '/Work',
        name: 'Work',
        component: () => import('../views/Work.vue')
    }
];
const router = new VueRouter({
    mode: 'history',
    routes
});

router.beforeResolve((to, from, next) => {
    if (to.name) {
        NProgress.start()
    }
    next()
});
router.afterEach(() => {
    NProgress.done()
});

export default router;
