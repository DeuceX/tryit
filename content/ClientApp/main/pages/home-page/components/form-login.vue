<template>
    <form class="form form-btn-right">
        <div class="form__item"><input v-model="email" type="email" placeholder="Email"></div>
        <div class="form__item"><input v-model="pass" type="password" placeholder="Password"></div>
        <button @click.prevent="login" class="form__btn">Login</button>
    </form>
</template>
<script>
    import * as authService from '../../authorization/api/authorization-service';
    export default {
        data() {
            return {
                name: '',
                pass: '',
                email: ''
            }
        },
        methods: {
            login: function () {
                let data = {
                    Email: this.email,
                    Password: this.pass,
                    RememberMe: true
                }
                let response = authService.login(data)
                    .then(function (response) {
                        localStorage.setItem("token", response.data.token);
                        localStorage.setItem("user", JSON.stringify(response.data.user));
                        window.location.href += "account";
                    });
            }
        }
    }
</script>
