<template>
  <div class="home">
    <div v-if="coldest">
      <h2>Coldest City:{{ coldest.name }}</h2>
      <p>{{ coldest.temperature }}</p>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      cities: [],
      coldest: null,
    };
  },

  methods: {
    async getWeather(city) {
      const res = await fetch(
        "https://goweather.herokuapp.com/weather/" + city
      );
      const json = await res.json();
      return json;
    },
  },

  async created() {
    let city = await this.getWeather("Toronto");
    this.coldest = {
      name: "Toronto",
      temperature: city.temperature,
    };

    city = await this.getWeather("Calgary");
    if (
      Number.parseInt(city.temperature) <
      Number.parseInt(this.coldest.temperature)
    )
      this.coldest = {
        name: "Calgary",
        temperature: city.temperature,
      };
    city = await this.getWeather("Vancouver");
    if (
      Number.parseInt(city.temperature) <
      Number.parseInt(this.coldest.temperature)
    )
      this.coldest = {
        name: "Vancouver",
        temperature: city.temperature,
      };
  },
};
</script>
