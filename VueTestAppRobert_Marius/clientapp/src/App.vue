<template>
    <div id="app">
        <Login :msg="msg" />
    </div>
</template>

<script>
    import Login from './components/Login.vue'

    export default {
        name: 'app',
        components: {
            Login
        },
        data() {
            return {
                msg: "Marius!"
            }
        }
    }
</script>

<style>
    #app {
        font-family: 'Avenir', Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        margin-top: 60px;
    }
</style>
