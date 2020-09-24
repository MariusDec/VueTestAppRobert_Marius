<template>
    <div>
        <div>{{msg}}</div>
        <div>Choose login type</div>
        <button data-v-3ecc9273="" type="button" class="md-button md-raised md-primary md-theme-demo-light">
            <div class="md-ripple">
                <div class="md-button-content">Contractor</div>
            </div>
        </button>
        <button data-v-3ecc9273="" type="button" class="md-button md-raised md-primary md-theme-demo-light">
            <div class="md-ripple">
                <div class="md-button-content">Admin</div>
            </div>
        </button>
    </div>
</template>

<script>
    export default {
        props: {
            msg: String
        }
    }
</script>