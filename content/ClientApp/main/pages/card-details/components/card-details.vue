<template>
  <div class="card-details align" :class="card.IsCompleted ? 'complete' : ''">
    <h1>{{ card.Name }}</h1>
    <div class="card-details__description flex-row">
      <div class="cards__img">
        <img :src="card.ImageUrl" alt="card" width="200" height="280" />
      </div>
      <div class="card-details__info">
        <div class="card-details__text"> {{ card.Description }} </div>
        <div class="card-details__btn">Complete!</div>
      </div>
    </div>
    <div class="card-details__complete" v-if="card.IsCompleted">
      <span>Your comment:</span>
      <div class="card-details__comment">{{ card.Comment }}</div>
    </div>
  </div>
</template>
<script>
  import * as cardService from '../../../api/card-service';

  export default {
    data() {
      return {
        forecasts: null,
        card: {}
      }
    },
    props: ['id'],

    async beforeMount() {
      let that = this;
      cardService.getCard(this.id)
        .then(function(response) {
          that.card = response.data;
        });
    }
  }
</script>
