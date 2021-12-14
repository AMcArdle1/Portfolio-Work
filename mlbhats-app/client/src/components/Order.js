//	This is the page that displays all user orders.
import { Component, Fragment } from 'react';
import AppNavbar from './AppNavbar';
import Footer from './Footer';
import PropTypes from 'prop-types';
import { connect } from 'react-redux';
import { getOrders } from '../actions/orderActions';
import {Card, CardBody, CardTitle, CardSubtitle, Alert, Container} from 'reactstrap';

class Orders extends Component {

    state = {
        loaded: false,
    }

    static propTypes = {
        isAuthenticated: PropTypes.bool,
        user: PropTypes.object.isRequired,
        order: PropTypes.object.isRequired,
        getOrders: PropTypes.func.isRequired
    }
	
    getOrders = async (id) => {
        await this.props.getOrders(id);
        this.state.loaded = true;
    }
	
    render(){
        const user = this.props.user;
        if(this.props.isAuthenticated && !this.props.order.loading && !this.state.loaded){
            this.getOrders(user._id);
        }
        return(
            <div>
                <AppNavbar/>
                {this.props.isAuthenticated ?
                    <Fragment>
                        {this.props.order.orders !== [] ? null :
                            <Alert 
                                color="info" 
                                className="text-center"
                            >
                                You have no orders!
                            </Alert>
                        } 
                    </Fragment>
                    :   <Alert 
                            color="danger" 
                            className="text-center"
                        >
                            Login to View!
                        </Alert>
                }
                {this.props.isAuthenticated && !this.props.order.loading && this.state.loaded && this.props.order.orders.length?
                    <Container>
                        <div className="order-cards">
                            <div className="row">
                                {this.props.order.orders.map((order)=>(
                                    <div className="col-md-12">
                                        <Card>
                                            <CardBody>
                                                <CardTitle tag="h4">
                                                    {order.items.length} items - Total cost: $ {order.bill}
                                                </CardTitle>
                                                
                                                <div className="row">
                                                {order.items.map((item)=>(
                                                    <div className="col-md-4">
                                                        <Card className="mb-2">
                                                            <CardBody>

                                                                <img
                                                                    src={item.imageURL}
                                                                    alt="hat"
                                                                />
                                                                
                                                                <CardTitle tag="h5">
                                                                    {item.name} 
                                                                    ({item.quantity} pieces)
                                                                </CardTitle>

                                                                <CardSubtitle tag="h6">
                                                                    $ {item.price} / each
                                                                </CardSubtitle>
                                                            </CardBody>
                                                        </Card>
                                                    </div>
                                                ))}
                                                </div>
                                            </CardBody>
                                        </Card>
                                        <br/>
                                    </div>                      
                                ))}
                            </div>
                        </div>
                        
                    </Container>
                :null}
                <Footer/>
            </div>
        )
    }
}

const mapStateToProps = (state) => ({
    order: state.order,
    isAuthenticated: state.auth.isAuthenticated,
    user: state.auth.user,
})

export default connect(mapStateToProps, {getOrders})(Orders);
