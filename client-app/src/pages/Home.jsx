import React, { useState } from "react";
import { Fab, ThemeProvider, createTheme } from "@mui/material";
import NotificationsIcon from "@mui/icons-material/Notifications";
import Hero from "../components/Hero/Hero";
import Services from "../components/Services/Services";
import Banner from "../components/Banner/Banner";
import Subscribe from "../components/Subscribe/Subscribe";
import Banner2 from "../components/Banner/Banner2";
import Footer from "../components/Footer/Footer";
import NewsComponent from "../components/News/NewsComponent";

const Home = () => {
  const [showNotifications, setShowNotifications] = useState(false);

  const theme = createTheme({
    palette: {
      notification: {
        main: '#F76C6C',
      },
    },
  });

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
    notificationToggle: {
      position: "fixed",
      bottom: "20px",
      left: "20px",
      zIndex: 1000,
    },
  };

  const toggleNotifications = () => {
    setShowNotifications(!showNotifications);
  };

  const closeNotifications = () => {
    setShowNotifications(false);
  };

  return (
    <ThemeProvider theme={theme}>
      <main style={styles.main}>
        <Fab
          color="notification"
          onClick={toggleNotifications}
          style={styles.notificationToggle}
          aria-label="notifications"
        >
          <NotificationsIcon />
        </Fab>
        <NewsComponent open={showNotifications} onClose={closeNotifications} />
        <Hero />
        <Services />
        <Banner />
        <Subscribe />
        <Banner2 />
        <Footer style={styles.headerFooter} />
      </main>
    </ThemeProvider>
  );
};

export default Home;
