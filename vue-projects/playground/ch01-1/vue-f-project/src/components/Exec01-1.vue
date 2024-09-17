// src/componenets/Exec01-1.vue

<template>
    <div>
        <h1>
            My First <span id="der"> {{ color }} </span> Vue Components!
        </h1>
    </div>
</template>
<script>
export default {
    data() {
        return {
            color: "Red",
        };
    },
};
</script>
<style>
h1 {
    font-family: "Avenir", Arial, Helvetica, sans-serif;
    text-align: center;
    color: #2c3e50;
    margin-top: 60px;
}

span {
    color: #00ff00;
}
</style>
