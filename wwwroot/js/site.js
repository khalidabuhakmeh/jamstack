import Vue from 'vue';
import vueCustomElement from 'vue-custom-element'
import helloWorld from './components/helloworld'

Vue.use(vueCustomElement);

Vue.customElement('hello-world', helloWorld);