<template>
    <div class="admin">
        <h1>Add new Licitations</h1>
        <div>
            <span>Summary: </span><input v-model="newLicitation.summary" placeholder="example" />
            <button @click="addNewLicitation" style="margin-left: 10px;">Add</button>
        </div>
        <h1>My licitations</h1>
        <ul>
            <li v-for="licitation in licitations" :key="licitation.id" style="display: flex;">
                <Licitation :canSendOffer="false" :licitation="licitation" />
            </li>
        </ul>
    </div>
</template>

<script>
    import Licitation from '@/components/Licitation.vue'
    export default {
        data() {
            return {
                licitations: [],
                newLicitation: {
                    summary: ""
                }
            }
        },
        mounted: function () {
            fetch('http://localhost:50598/licitations', { method: 'get' }).then((response) => {
                return response.json();
            }).then((jsonData) => {
                this.licitations = jsonData;
            })
        },
        methods: {
            addNewLicitation() {
                fetch('http://localhost:50598/licitations',
                {
                    method: 'post',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(this.newLicitation)
                }).then((response) => {
                    return response.json();
                }).then((jsonData) => {
                    this.newLicitation.summary = "";
                    this.licitations.push(jsonData);
                })
            }
        },
        components: {
            Licitation
        }
    }
</script>
