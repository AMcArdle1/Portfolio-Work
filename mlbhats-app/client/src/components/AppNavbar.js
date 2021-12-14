//	The Navbar contains the Login Modal, Register modal, 
//	Logout button, and links to various pages on the website.
import { Component, Fragment } from 'react';
import { Collapse, Navbar, NavbarToggler, NavbarBrand, Nav, NavLink } from 'reactstrap';
import RegisterModal from './auth/registerModal';
import Logout from './auth/Logout';
import LoginModal from './auth/loginModal';
import { connect } from 'react-redux';
import PropTypes from 'prop-types';
import 'bootstrap/dist/css/bootstrap.min.css';

class AppNavbar extends Component {
    state = {
        isOpen: false
    }

    static propTypes = {
        auth: PropTypes.object.isRequired
    }

    toggle = () => {
        this.setState({
            isOpen: !this.state.isOpen
        });
    }

    render() {
        const { isAuthenticated, user } = this.props.auth;

        const authLinks = (
            <Fragment>
                    <span className="navbar-text me-2">
                        <strong>{ user ? `Welcome ${user.name}` : ''}</strong>
                    </span>
                
                    <NavLink href="/">Home</NavLink>
                
                    <NavLink href="/cart">Cart</NavLink>
                
                    <NavLink href="/orders">Orders</NavLink>
                
                    <Logout/>
            </Fragment>
        );

        const guestLinks = (
            <Fragment>
                    <RegisterModal/>
                    <LoginModal/>
            </Fragment>
        );
        
        return(
            <div>
                <Navbar dark expand="lg" className="mb-5 bg-dark">
                    <NavbarBrand 
                        href="/"
                    >
                        Hats "R" Us
                    </NavbarBrand>
                    
                    <NavbarToggler
                        aria-controls ="navbar-nav" 
                        onClick={this.toggle}
                    />

                    <Collapse
                        isOpen={this.state.isOpen} 
                        navbar
                    >
                        <Nav navbar> 
                            { isAuthenticated ? authLinks: guestLinks}                               
                        </Nav>
                    </Collapse>
                </Navbar>
            </div>
        );
    }
}
const mapStateToProps = state => ({
    auth: state.auth
})

export default connect(mapStateToProps, null)(AppNavbar);
