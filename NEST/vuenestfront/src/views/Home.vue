<template>
    <div class="home">
        <img alt="Vue logo" src="../assets/logo.png" />
        <HelloWorld msg="Welcome to Your Vue.js App" />
        <h1>{{IsolationPointList}}</h1>
        <ul>
            <li v-for="Iso in IsolationPointList" :key="Iso.UDC">
                <h1>This is an about page {{Iso.parentSystem}}</h1>
            </li>
        </ul>
    </div>
</template>

<script>
    import axios from 'axios';
// @ is an alias to /src
    export default {

  name: "Home",
  components: {
        },
        data() {
            return {
                IsolationPointList: []
            }
        },
        mounted() {
            axios
                .get('http://localhost:44395/api/IsoPoint')
                .then(response => {
                    return response.json()
                })

                .then(response => {
                    this.IsolationPointList = response.data
                })
                .catch(error => {
                    console.log('There was an error:', this.IsolationPointList.UDC)
                })
            //fetch('/api/IsoPoint').then(data => { this.IsolationPointList = data })
        }
};
</script>
