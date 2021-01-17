<template>
    <div>
        <b-navbar toggleable="lg" type="dark" variant="info" fixed="top">
            <b-navbar-brand to="/">
                <img src="@/assets/NavyLogo.png" />
            </b-navbar-brand>
            <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

            <b-collapse id="nav-collapse" is-nav>
                <b-navbar-nav>
                    <b-nav-item href="#" :to="{name:'Dash'}">Dash</b-nav-item>
                    <b-nav-item href="#" :to="{name:'Audit'}">Audit</b-nav-item>
                    <b-nav-item href="#" :to="{name:'Explore'}">Explore</b-nav-item>
                    <b-nav-item href="#" :to="{name:'Isolate'}">Isolate</b-nav-item>
                    <b-nav-item href="#" :to="{name:'Work'}">Work</b-nav-item>
                </b-navbar-nav>
                <headtitle>Navy Engineering <br /> Safety Toolbox</headtitle>
                <!-- Right aligned nav items -->
                <b-navbar-nav class="ml-auto">

                    <b-nav-item href="#" :to="{name:'Contact'}">Contact</b-nav-item>
                    <b-nav-item href="#" :to="{name:'Help'}">Help</b-nav-item>
                    <b-nav-item-dropdown right>
                        <!-- Using 'button-content' slot -->
                        <template #button-content>
                            <em>User</em>
                        </template>
                        <b-dropdown-item href="#">Profile</b-dropdown-item>
                        <b-dropdown-item href="#">Sign Out</b-dropdown-item>
                    </b-nav-item-dropdown>
                </b-navbar-nav>
            </b-collapse>
        </b-navbar>
    </div>
</template>

<script>
    export default {
        name: 'Header'
    };


</script>

<style scoped>
    .headtitle {
        padding-left: 250px;
        color: black;
        font-size: 30px;
    }
</style>

