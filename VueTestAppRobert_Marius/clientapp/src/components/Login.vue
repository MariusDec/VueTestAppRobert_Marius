<template>
    <div>
        <div>{{msg}}</div>
        <div>Choose login type</div>
        <div id="nav">
            <router-link to="/contractor" data-v-3ecc9273="" type="button" class="md-button md-raised md-primary md-theme-demo-light">
                <div class="md-ripple">
                    <div class="md-button-content">Contractor</div>
                </div>
            </router-link>
            <router-link to="/admin" data-v-3ecc9273="" type="button" class="md-button md-raised md-primary md-theme-demo-light">
                <div class="md-ripple">
                    <div class="md-button-content">Admin</div>
                </div>
            </router-link>
        </div>
        <router-view />
    </div>
</template>

<script>
    export default {
        props: {
            msg: String
        }
    }
</script>