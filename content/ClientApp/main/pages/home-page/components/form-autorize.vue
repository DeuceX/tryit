<template>
  <form class="form form-btn-right">
    <div class="form__item"><input v-model="name" type="text" placeholder="Name Surname"></div>
    <div class="form__item"><input v-model="nick" type="text" placeholder="Nickname"></div>
    <div class="form__item"><input v-model="email" type="email" placeholder="Email"></div>
    <div class="form__item"><input v-model="pass" type="password" placeholder="Password"></div>
    <button @click.prevent="register" class="form__btn">Go</button>
    
  </form>
</template>
<script>
  import * as authService from '../../authorization/api/authorization-service';
  export default {
    data() {
      return {
        name: '',
        email: '',
        nick: '',
        pass: ''
      }
    },
    methods: {
      register: function () {
        let usr = {
          Email: this.email,
          NickName: this.nick,
          FullName: this.name,
          Password: this.pass
        }
        authService.registr(usr)
            .then(function (response) {
                alert(response.data);
                document.querySelector('.main__login').click();
            });
      }
    }
  }
</script>

