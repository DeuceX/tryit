<template>
  <div id="app" :class="$route.path==='/' ? 'mainpage' : ''">
    <div class="wrapper">
      <my-header></my-header>
      <div class="content"><router-view></router-view></div>
      <my-footer></my-footer>
    </div>
  </div>
</template>
<script>
  import Vue from 'vue'
  import HomePage from '../home-page/home-page'
  import header from './components/header'
  import footer from './components/footer'  
  import AccountPage from '../account/account'
  import SettingsPage from '../settings/settings'  

  Vue.component('home-page', HomePage);  
  Vue.component('account', AccountPage);  
  Vue.component('my-header', header);
  Vue.component('my-footer', footer);  
  Vue.component('settings', SettingsPage);

  export default {
    data() {
      return {}
    },
  }
</script>
