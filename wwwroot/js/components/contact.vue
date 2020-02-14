<template>
    <form id="contact-form" action="/contact" method="post">
        <div class="row">
            <div class="col-md-6">
                <div class="contact-form mt-45">
                    <label for="name">Enter Your Name</label>
                    <input id="name" v-model="name" type="text" name="name" placeholder="Full Name">
                </div> <!-- contact-form -->
            </div>
            <div class="col-md-6">
                <div class="contact-form mt-45">
                    <label for="email">Enter Your Email</label>
                    <input id="email" v-model="email" type="email" name="email" placeholder="Email">
                </div> <!-- contact-form -->
            </div>
            <div class="col-md-12">
                <div class="contact-form mt-45">
                    <label for="message">Your Message</label>
                    <textarea id="message" v-model="message" name="message" placeholder="Enter your message..."></textarea>
                </div> <!-- contact-form -->
            </div>
            <p class="form-message"></p>
            <div class="col-md-12">
                <div class="contact-form mt-45">
                    <button v-on:click="sendMessage" type="submit" class="main-btn">Send Now</button>
                </div> <!-- contact-form -->
            </div>
        </div> <!-- row -->
    </form>
</template>

<script>
    import axios from 'axios';
    
    export default {
        data() {
            return {
                name : '',
                email : '',
                message : '',
            }
        },
        methods : {
            sendMessage(event) {
                event.preventDefault();
                let data = { 
                    name: this.name, 
                    email: this.email, 
                    message: this.message
                };
                
                console.log(this.name);

                axios
                    .post(`/contact`, data)
                    .then(response => {
                        alert(`Thank You ${response.data.name}!`);
                    });
            }
        }
    }
</script>