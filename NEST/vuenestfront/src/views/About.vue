<template>
  <div class="about">
      <h1>This is an about page {{IsolationPointList}}</h1>
  </div>
</template>

<script>
    export default {       
        name: 'app',
        data() {
            return {
                IsolationPointList: null
            }
        },
        mounted() {
            fetch('/api/IsoPoint').then(data => { this.IsolationPointList = data })
        }
    }

</script>