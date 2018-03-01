<template>
  <div class="cards">
    <account-info></account-info>
    <div class="cards__items flex-row align">
      <div 
        class="cards__item" 
        v-for="(card, index) in cards" 
        :key="index" 
        :class="card.isCompleted ? 'cards__done' : ''">
        <h3>{{ card.name }}</h3>
        <router-link :to="'/card-details/' + card.Id">
          <div class="cards__img">
            <img :src="'{{ card.ImageUrl }}'" alt="card" width="280" height="200" />
          </div>
        </router-link>
      </div>
    </div>
  </div>
</template>

<script>
  import AccountInfo from './components/account-info';
  import * as cardService from '../../api/card-service';

  export default {
    data() {
      return {
        cards: {}
      }
    },
    components: {
      accountInfo: AccountInfo
    },
    async beforeMount() {
      let that = this;
      cardService.getAll()
        .then(function(response) {
            that.cards = response.data;
        });;
    }
  }
</script>
