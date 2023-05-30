<template>
  <div id="home-view">
    <h1>City with lowest temperature</h1>
    <div v-if="loading">Loading...</div>
    <div v-else>
      <p>City: {{ minTempCity }}</p>
      <p>Temperature: {{ minTemp }} °C</p>
    </div>
  </div>
</template>

<script>
export default {
  name: 'HomeView',
  data() {
    return {
      cities: ['Toronto', 'Vancouver', 'Calgary'],
      minTempCity: '',
      minTemp: Infinity,
      loading: true,
    }
  },
  async created() {
    await Promise.all(this.cities.map(async (city) => {
      try {
        const response = await fetch(`https://goweather.herokuapp.com/weather/${city}`);
        const data = await response.json();
        const temp = parseInt(data.temperature);
        if (temp < this.minTemp) {
          this.minTemp = temp;
          this.minTempCity = city;
        }
      } catch (error) {
        console.error('Error:', error);
      }
    }));
    this.loading = false;
  }
}
</script>

<style>
#home-view {
  display: flex;
  flex-direction: column;
  align-items: center;
}
</style>