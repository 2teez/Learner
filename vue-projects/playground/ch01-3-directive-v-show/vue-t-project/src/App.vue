<template>
    <section>
        <div>
            <h1 v-once v-show="true">{{ text }}</h1>
            <h2 v-show="false" v-html="html"></h2>
            <a
                v-show="true"
                :href="link.url"
                :tabindex="link.tabindex"
                :target="link.target"
                >{{ link.title }}</a
            >

            <div class="form">
                <label> Name: <input type="text" v-model="name" /></label>
                <label>
                    Preferred JavaScript Style
                    <select name="langauage" v-model="language">
                        <option value="JavaScript" default>JavaScript</option>
                        <option value="TypeScript">TypeScript</option>
                        <option value="CoffeeScript">CoffeeScript</option>
                        <option value="Dart">Dart</option>
                    </select>
                </label>
            </div>
        </div>
        <ul class="overview">
            <li><strong>Overview: </strong></li>
            <li>Name: {{ name }}</li>
            <li>Preference: {{ langauge }}</li>
        </ul>
    </section>
</template>
<script setup>
const text = "Declarative Text";
const html = "<span> Stylize <br />HTML in <br /><b>Vue...</b> </span>";
const link = {
    title: "Go to google",
    url: "https://google.com",
    tabindex: 1,
    target: "_blank",
};
const name = "Enter your name";
</script>
<style>
.form {
    display: flex;
    justify-content: space-evenly;
    max-width: 800px;
    padding: 40px 20px;
    border-radius: 10px;
    margin: 0 auto;
    background: #ececec;
}

.overview {
    display: flex;
    flex-direction: column;
    justify-content: space-evenly;
    max-width: 300px;
    padding: 40px 20px;
    border-radius: 10px;
    margin: 40 auto;
    border-radius: 10px;
    border: 1px solid #ececec;
}

.overview > li {
    list-style: none;
}

.overview > li + li {
    margin-top: 20px;
}
</style>
