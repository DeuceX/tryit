<template>
  <div class="main flex-row">
    <div class="main__parallax">
      <div id="scene">
        <div class='stars stars--1' data-depth="0.5"></div>
        <div class='stars stars--2' data-depth="0.3"></div>
        <div class='stars stars--3' data-depth="0.7"></div>
      </div>
    </div>
    <div class="main__form">
      <div 
        class="main__form-top"
        v-for="(form, formIndex) in forms"
        :key="formIndex"
        :class="(formIndex == i) ? 'active' : ''">
        <div class="header__logo"> {{form.title}} </div>
        <div class="main__separator">or</div>

        <div 
          class="main__login"
          v-for="(form, formIndex) in forms"
          :key="formIndex + 15"
          :class="(formIndex == i) ? 'active' : ''"
          @click="myFilter"> 
          {{form.link}}
        </div>
      </div>
      <div 
        class="main__form-content"
        v-for="(form, formIndex) in forms"
        :class="(formIndex == i) ? 'active' : ''"
        :key="formIndex + 10">
        <component :is="forms[formIndex].content"></component>
      </div>

    </div>
  </div>
</template>

<script>
  import Parallax from 'parallax-js/dist/parallax';
  import FormAutorize from './components/form-autorize';
  import FormLogin from './components/form-login';

  export default {
    data() {
      return {
        i: false,
        forms: [
          {
            formIndex: 0,
            title: 'try it yourself',
            link: 'login',
            content: 'form-autorize'
          },
          {
            formIndex: 1,            
            title: 'login',
            link: 'registr',
            content: 'form-login'
          }
        ]
      }
    },
    methods: {
      myFilter: function(){
        this.i = !this.i;
        
      }
    },
    mounted: function() {
      const scene = document.getElementById('scene');
      if (scene) {
        var parallaxInstance = new Parallax(scene, {
          relativeInput: true
        });
      }
    },
    components: {
      formAutorize: FormAutorize,
      formLogin: FormLogin      
    }
  }
</script>
