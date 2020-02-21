import Vue from 'vue';
import vueCustomElement from 'vue-custom-element'
import helloWorld from './components/helloworld'
import contactForm from './components/contact'
import newsletter from "./components/newsletter";
import { bus } from "./eventbus";

Vue.use(vueCustomElement);

Vue.customElement('hello-world', helloWorld);
Vue.customElement('news-letter', newsletter);
Vue.customElement('contact-form', contactForm);

window.bus = bus;
