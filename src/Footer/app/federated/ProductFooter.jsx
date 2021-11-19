import React from "react";
import "./../styles/index.css";

const ProductFooter = () => {
  return (
    <footer className="footer-section">
        <div className="container">
            <div className="footer-content pt-5 pb-5">
                <div className="row">
                    <div className="col-sm-6 col-md-5 col-lg-64 mobile-margin">
                        <div className="footer-widget">
                            <div className="footer-widget-heading">
                                <h3>Book a Product Tour</h3>
                            </div>
                            <div className="subscribe-form">
                                <form action="#">
                                    <input type="text" placeholder="Email Address" />
                                    <button>Start</button>
                                </form>
                            </div>
                        </div>
                    </div>
                  <div className="col-sm-6 col-md-5 offset-md-2">
                        <div className="footer-widget">
                            <div className="footer-widget-heading">
                                <h3>Useful Links</h3>
                            </div>
                            <ul>
                                <li><a href="#">Technology</a></li>
                                <li><a href="#">Sustainability</a></li>
                                <li><a href="#">About Us</a></li>
                                <li><a href="#">Our Experts</a></li>
                                <li><a href="#">Contact Us</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div className="copyright-area">
            <div className="container">
                <div className="row">
                    <div className="col-xl-4 col-lg-4 text-center text-lg-left">
                        <div className="copyright-text">
                            <p>Copyright &copy; 2021, All Right Reserved</p>
                        </div>
                    </div>
                    <div className="col-xl-4 col-lg-4 text-center">
                        <div className="footer-menu">
                            <ul>
                                <li><a href="#">Corporate</a></li>
                                <li><a href="#">Terms</a></li>
                                <li><a href="#">Privacy</a></li>
                                <li><a href="#">Policy</a></li>
                                <li><a href="#">Contact</a></li>
                            </ul>
                        </div>
                    </div>
                  <div className="col-xl-4 col-lg-4 text-center text-lg-right">
                        <div className="footer-social-icon">                        
                           <a href="#"><i className="fab fa-facebook-f facebook-bg"></i></a>
                           <a href="#"><i className="fab fa-twitter twitter-bg"></i></a>
                           <a href="#"><i className="fab fa-google-plus-g google-bg"></i></a>
                         </div>
                    </div>
                </div>
            </div>
        </div>
    </footer>
  )
};

export default ProductFooter;