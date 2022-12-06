import React from'react';
import 'firebaseui/dist/firebaseui.css';
import Firebase from '../server/firebase'; // o users

class Login extends React.Component {
    state = {
        autenticado: false, //inicializo asi
        userName: '',
        email: '', 
        password: '',
        firebase: null //variable estado para almacenar
    };
    
    componentDidMount() {
        const firebase = new Firebase ();

        //registro si esta el usuario esta conectado
        firebase.auth.onAuthStateChanged(authuser => {
            authuser
            ? this.setState({
                autenticado: true,
                userName: firebase.auth.currentUser.username,
                firebase : firebase
            })
            :firebase.firebaseui.start("#firebaseui-auth-container", {
                signInSuccessUrl : "/",
                credentialHelper:"none",
                callbacks:{
                    signInSuccessWithAuthResult: (authresult, redirectUrl) => {
                        this.setState({
                            autenticado: true,
                            userName: firebase.auth.currentUser.email,
                            firebase : firebase
                        })

                        return false;
                    },

                    signInOptions: [
                        {
                            provider: firebase.autorization.EmailAuthProvider.PROVIDER_ID
                        }
                    ]
                }
            })
        })
    }

    render() {
        return this.state.autenticado
        ?(
            <React.Fragment>
                <div>Usuario Loguado { this.state.userName}</div>
                
                <a href='#' onClick={()=> { this.state.firebase.auth.singOut().then(success=> {this.setState({autenticado:false})})} }>Salir</a>
            </React.Fragment>
        )
        : <div id="firebaseui-auth-container"></div>
    }
}

export default Login;

