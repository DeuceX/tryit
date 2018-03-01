<template>
  <div class="container">
      <div class="row">
          <div class="col-md-offset-2 col-md-8">
              <h1>Card details</h1>
          </div>
      </div>
      <div class="row">
          <div class="col-md-8 col-md-offset-2">
              <h3>{{ card.Name }}</h3>
              <h4>{{ card.Description }}</h4>
              <div class="img-wrap">
                  <img :src="card.ImageUrl" alt="card photo" />
                  <div v-if="card.IsCompleted" class="completed">
                      This Card is Completed!
                  </div>
              </div>
          </div>
      </div>
      <div class="row" v-if="card.IsCompleted">
          <div class="col-md-12">
              <h3>This card was completed!</h3>
              <hr />
              <h4><i>Your comment:</i></h4>
              <h4>{{ card.Comment }}</h4>
          </div>
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
