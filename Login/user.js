import app from 'firebase/app';
import 'firebase/auth';
import * as firebaseui from 'firebaseui';

const firebaseConfig = {
    apiKey: "AIzaSyDm6AJhN6BE6ZvtAc_E2tZU8tBrRZ6phlE",
    authDomain: "login-6cd21.firebaseapp.com",
    projectId: "login-6cd21",
    storageBucket: "login-6cd21.appspot.com",
    messagingSenderId: "152413600316",
    appId: "1:152413600316:web:b432d6a35703e96a04e139",
    measurementId: "G-WEFKCZ9NV8"
  };

class Firebase {
    constructor(){
        app.initializeApp(firebaseConfig);
        this.auth = app.auth();
        this.autorization = app.auth;
        this.firebase = new firebaseui.auth.AuthUI(app.auth());


    }
}

export default Firebase;