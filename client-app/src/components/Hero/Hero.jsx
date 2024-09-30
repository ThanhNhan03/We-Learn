import React, { useContext } from "react";
import Navbar from "../Navbar/Navbar";
import { IoIosArrowRoundForward } from "react-icons/io";
import HeroPng from "../../assets/hero.png";
import { motion } from "framer-motion";
import { Container, Grid, Box, Button } from '@mui/material';
import { UserContext } from '../../contexts/UserContext'; // Import UserContext
import '../style/WebStyle.css';

export const FadeUp = (delay) => {
  return {
    initial: {
      opacity: 0,
      y: 50,
    },
    animate: {
      opacity: 1,
      y: 0,
      transition: {
        type: "spring",
        stiffness: 100,
        duration: 0.5,
        delay: delay,
        ease: "easeInOut",
      },
    },
  };
};

const Hero = () => {
  const { User } = useContext(UserContext);

  return (
    <section className="hero-section">
      <Navbar />
      <Container>
        <Grid container spacing={4} minHeight="650px">
          {/* Brand Info */}
          <Grid item xs={12} md={6} display="flex" flexDirection="column" justifyContent="center" py={{ xs: 14, md: 0 }} zIndex={20}>
            <Box textAlign={{ xs: 'center', md: 'left' }} maxWidth={{ lg: 400 }} mb={10}>
              <motion.h1
                variants={FadeUp(0.6)}
                initial="initial"
                animate="animate"
                className="hero-heading text-4xl lg:text-6xl font-bold !leading-snug"
              >
                {User ? (
                  <>
                    <span className="hero-span hero-title">WELLCOME {User.firstname} {User.lastname}</span>
                    <br />
                    <span style={{ fontSize: "1.5rem" }} className="hero-subtitle">Let's explore the world of knowledge together :D</span>
                  </>
                ) : (
                  <>
                    <span className="hero-span hero-title">WE LEARN</span>
                    <br />
                    <span className="hero-subtitle">Share knowledge, build future</span>
                  </>
                )}
              </motion.h1>
              <motion.div
                variants={FadeUp(0.8)}
                initial="initial"
                animate="animate"
                className="flex justify-center md:justify-start"
              >
                {/* Button redirect to get-started */}
                <Button href="/get-started" variant="contained" className="hero-button" endIcon={<IoIosArrowRoundForward className="text-xl group-hover:translate-x-2 group-hover:-rotate-45 duration-300" />}>
                  Get Started
                </Button>
              </motion.div>
            </Box>
          </Grid>
          {/* Hero Image */}
          <Grid item xs={12} md={6} display="flex" justifyContent="center" alignItems="center">
            <motion.img
              initial={{ x: 50, opacity: 0 }}
              animate={{ x: 0, opacity: 1 }}  
              transition={{ duration: 0.6, delay: 0.4, ease: "easeInOut" }}
              src={HeroPng}
              alt=""
              className="hero-image relative z-10 drop-shadow"
            />
          </Grid>
        </Grid>
      </Container>
    </section>
  );
};

export default Hero;
