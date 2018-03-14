<template>
    <div class="cards">
        <account-info></account-info>
        <div class="cards__tabs align flex-row">
            <div class="cards__tab">Basic</div>
            <div class="cards__tab">Add</div>
        </div>
        <div class="cards__items flex-row align">
            <div class="cards__item"
                 v-for="(card, index) in cards"
                 :key="index"
                 :class="card.isCompleted ? 'cards__done' : ''">
                <router-link :to="'/card-details/' + card.Id">
                    <div class="cards__img">
                        <img :src="card.ImageUrl" alt="card" width="200" height="280" />
                    </div>
                    <div class="cards__name">{{ card.Name }}</div>
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
                .then(function (response) {
                    that.cards = response.data;
                })
                .catch(function (error) {
                    console.log(error.response.status);
                });
        }
    }
</script>
