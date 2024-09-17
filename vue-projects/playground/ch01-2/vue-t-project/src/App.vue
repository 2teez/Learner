<template>
    <div>
        <h2>
            {{ isUpperCase ? title.toUpperCase() : title }}
        </h2>
    </div>
</template>
<script setup>
const title = "My First Vue Components!";
const isUpperCase = false;
</script>
<style></style>
