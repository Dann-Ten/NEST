<template>
  <div class="about">
      <h1>This is an about page {{users}}</h1>
  </div>
</template>

<script>
    export default {
        name: 'app',
        data() {
            return {
                users: null
            }
        },
        mounted() {
            fetch('/api/IsoPoint')
                .then(response => {
                    return response.json()
                })
                .then(data => {
                    this.users = data
                })
        }
    }

</script>