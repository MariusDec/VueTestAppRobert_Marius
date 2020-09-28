<template>
  <div class="contractor">
    <h1>Licitations:</h1>
    <ul>
        <li v-for="licitation in licitations" :key="licitation.id" style="display: flex;">
            <Licitation :canSendOffer="true" :licitation="licitation"/>
        </li>
    </ul>
  </div>
</template>

<script>
    import Licitation from '@/components/Licitation.vue'
    export default {
        data() {
            return {
                licitations: []
            }
        },
        mounted: function () {
            fetch('http://localhost:50598/licitations', { method: 'get' }).then((response) => {
                return response.json();
            }).then((jsonData) => {
                this.licitations = jsonData;
            })
        },
        components: {
            Licitation
        }
    }
</script>
