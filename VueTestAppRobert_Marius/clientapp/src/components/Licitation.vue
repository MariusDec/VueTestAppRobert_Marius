<template>
    <div style="display: flex;">
        <div>Id: {{licitation.id}}</div>
        <div style="margin-left: 10px; margin-right: 10px;"> | </div>
        <div>Summary: {{licitation.summary}}</div>
        <div style="margin-left: 10px; margin-right: 10px;"> | </div>
        <div>Date Posted: {{licitation.date}}</div>
        <div style="margin-left: 10px; margin-right: 10px;"> | </div>
        <button v-if="canSendOffer && !isSendingOffer" @click="showOffer"> Send Offer </button>
        <router-link v-if="!canSendOffer" :to="`/licitation/${licitation.id}`"> Details </router-link>
        <div v-if="isSendingOffer">
            <input v-model="offerSummary" placeholder="offer"/>
            <button @click="sendOffer">Send</button>
        </div>
    </div>
</template>

<script>
    export default {
        props: {
            canSendOffer: Boolean,
            licitation: Object
        },
        methods: {
            sendOffer: sendOffer,
            showOffer: showOffer,
            details: details
        },
        data() {
            return {
                isSendingOffer: false,
                offerSummary: ""
            }
        }
    }

    function sendOffer() {
        var offer = {
            summary: this.offerSummary,
            licitationId: this.licitation.id
        }

        this.isSendingOffer = !this.isSendingOffer;
        this.offerSummary = "";

        fetch('http://localhost:50598/offers',
            {
                method: 'post',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(offer)
            });
    }

    function showOffer() {
        this.isSendingOffer = !this.isSendingOffer;
    }

    function details() {

    }

</script>