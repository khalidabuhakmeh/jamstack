<template>
    <div class="header-singup" data-wow-duration="1s" data-wow-delay="0.8s">
        <label style="display:none" for="newsletter">Newsletter Signup</label>
        <input id="newsletter" type="text" v-model="email" placeholder="username@yourdomain.com">
        <button class="main-btn" v-on:click="signUp">Sign Up</button>
    </div>
</template>

<script>
    import axios from 'axios';
    
    export default {
        data() {
            return {
                email : '',
            }
        },
        methods : {
            signUp(event) {
                event.preventDefault();
                let data = {
                    email: this.email,
                };

                axios
                    .post(`/newsletter`, data)
                    .then(response => {
                        alert(`Thank You!`);
                    });
            }
        }
    }
</script>