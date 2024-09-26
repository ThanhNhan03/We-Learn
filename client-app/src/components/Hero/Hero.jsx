import React from "react";
import Navbar from "../Navbar/Navbar";
import { IoIosArrowRoundForward } from "react-icons/io";
import Blob from "../../assets/blob.svg";
import HeroPng from "../../assets/hero.png";
import { animate, motion } from "framer-motion";
import { Container, Grid, Box, Typography, Button } from '@mui/material';

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
  return (
    <section className="bg-light overflow-hidden relative">
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
                className="text-3xl lg:text-5xl font-bold !leading-snug"
              >
                Let's Learn to build a{" "}
                <span className="text-secondary">Website</span> for your business
              </motion.h1>
              <motion.div
                variants={FadeUp(0.8)}
                initial="initial"
                animate="animate"
                className="flex justify-center md:justify-start"
              >
                <Button variant="contained" color="primary" endIcon={<IoIosArrowRoundForward className="text-xl group-hover:translate-x-2 group-hover:-rotate-45 duration-300" />}>
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
              className="w-[400px] xl:w-[600px] relative z-10 drop-shadow"
            />
            <motion.img
              initial={{ x: -50, opacity: 0 }}
              animate={{ x: 0, opacity: 1 }}
              transition={{ duration: 0.6, delay: 0.2, ease: "easeInOut" }}
              src={Blob}
              alt=""
              className="absolute -bottom-32 w-[800px] md:w-[1500px] z-[1] hidden md:block"
            />
          </Grid>
        </Grid>
      </Container>
    </section>
  );
};

export default Hero;
