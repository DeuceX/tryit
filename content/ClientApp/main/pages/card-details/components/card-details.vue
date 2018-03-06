<template>
  <div class="card-details align" :class="card.IsCompleted ? 'complete' : ''">
    <h1>{{ card.Name }}</h1>
    <div class="card-details__description flex-row">
      <div class="cards__img">
        <img :src="card.ImageUrl" alt="card" width="200" height="280" />
      </div>
      <div class="card-details__info">
        <div class="card-details__text">
          <!-- {{ card.Description }}  -->
          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
        </div>
        <div class="btn">Confirm!</div>
      </div>
    </div>
    <form class="form card-details__complete" v-if="card.IsCompleted">
      <div class="form__item">
        <textarea placeholder="Your comment"></textarea>
      </div>
      <div class="form__jc">
        <label class="form__file">
          <input type="file">
          <span>Add Photo</span>
        </label>
        <button class="form__btn">Ok!</button>
      </div>
    </form>
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
