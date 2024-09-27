import React from "react";
import Hero from "../components/Hero/Hero";
import Services from "../components/Services/Services";
import Banner from "../components/Banner/Banner";
import Subscribe from "../components/Subscribe/Subscribe";
import Banner2 from "../components/Banner/Banner2";
import Footer from "../components/Footer/Footer";

const Home = () => {
  const styles = {
    main: {
      backgroundColor: "#A8D0E6", 
      color: "#374785", 
      overflowX: "hidden",
    },
    headerFooter: {
      backgroundColor: "#24305E",   
      color: "#FFFFFF",   
    },
    button: {
      backgroundColor: "#F76C6C", 
      color: "#FFFFFF",   
    },
    link: {
      color: "#F8E9A1", 
    },
  };

  return (
    <main style={styles.main}>
      <Hero />
      <Services />
      <Banner />
      <Subscribe />
      <Banner2 />
      <Footer style={styles.headerFooter} />
    </main>
  );
};

export default Home;
