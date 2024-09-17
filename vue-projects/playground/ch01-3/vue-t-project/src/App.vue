<template>
    <div>
        <h1 v-if="false" v-once>{{ text }}</h1>
        <h2 v-html="html" v-else-if="false" />
        <a v-else :href="link.url" :target="link.target" :tabindex="link.tab">{{
            link.title
        }}</a>
    </div>
</template>
<script setup>
const text = "Directive Text...";
const html = "Stylize<br/>HTML in<br/><b>your data</b>";
const link = {
    title: "Go to google",
    url: "https://google.com",
    tab: 1,
    target: "_blank",
};
</script>
<style></style>
