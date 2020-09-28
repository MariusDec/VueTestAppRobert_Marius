<template>
    <div class="contractor">
        <h1>Offers:</h1>
        <ul>
            <li v-for="offer in offers" :key="offer.id" style="display: flex;">
                Id: {{offer.id}}
                <div style="margin-left: 10px; margin-right: 10px;"> | </div>
                Summary: {{offer.summary}}
                <div style="margin-left: 10px; margin-right: 10px;"> | </div>
                Date: {{offer.date}}
            </li>
        </ul>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                licitation: {},
                offers: []
            }
        },
        mounted: function () {
            var url = new URL('http://localhost:50598/offers');
            url.searchParams.append('licitationId', this.$route.params.id);
            fetch(url,
            {
                method: 'get'
            }).then((response) => {
                return response.json();
            }).then((jsonData) => {
                this.offers = jsonData;
            })
        }
    }
</script>