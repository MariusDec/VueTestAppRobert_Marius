<template>
  <div class="contractor">
    <h1>Licitations:</h1>
    <ul>
        <li v-for="licitation in licitations" :key="licitation.id" style="display: flex;">
            <div>Id: {{licitation.id}}</div>
            <div style="margin-left: 10px; margin-right: 10px;"> | </div>
            <div>Summary: {{licitation.summary}}</div>
            <div style="margin-left: 10px; margin-right: 10px;"> | </div>
            <div>Date Posted: {{licitation.date}}</div>
        </li>
    </ul>
  </div>
</template>

<script>
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
        }
    }
</script>
