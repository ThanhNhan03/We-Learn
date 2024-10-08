import React from "react";
import { RiComputerLine } from "react-icons/ri";
import { CiMobile3 } from "react-icons/ci";
import { TbWorldWww } from "react-icons/tb";
import { IoMdHappy } from "react-icons/io";
import { BiSupport } from "react-icons/bi";
import { IoPulseOutline } from "react-icons/io5";
import { motion } from "framer-motion";
import { Container, Grid, Box, Typography, Paper } from '@mui/material';

const ServicesData = [
  {
    id: 1,
    title: "Web Development",
    link: "#",
    icon: <TbWorldWww />,
    delay: 0.2,
  },
  {
    id: 2,
    title: "Mobile development",
    link: "#",
    icon: <CiMobile3 />,
    delay: 0.3,
  },
  {
    id: 3,
    title: "Software development",
    link: "#",
    icon: <RiComputerLine />,
    delay: 0.4,
  },
  {
    id: 4,
    title: "Satisfied clients",
    link: "#",
    icon: <IoMdHappy />,
    delay: 0.5,
  },
  {
    id: 5,
    title: "SEO optimization",
    link: "#",
    icon: <IoPulseOutline />,
    delay: 0.6,
  },
  {
    id: 6,
    title: "24/7 support",
    link: "#",
    icon: <BiSupport />,
    delay: 0.7,
  },
];

const SlideLeft = (delay) => {
  return {
    initial: {
      opacity: 0,
      x: 50,
    },
    animate: {
      opacity: 1,
      x: 0,
      transition: {
        duration: 0.3,
        delay: delay,
        ease: "easeInOut",
      },
    },
  };
};

const Services = () => {
  const styles = {
    section: {
      backgroundColor: "#A8D0E6",   
    },
    heading: {
      color: "#374785", 
    },
    paper: {
      backgroundColor: "#F8E9A1",   
      '&:hover': {
        backgroundColor: "#FFFFFF",   
        transform: 'scale(1.1)',
        boxShadow: 6,
      },
      transition: 'transform 0.3s ease-in-out',
    },
    iconBox: {
      fontSize: '2rem',
      marginBottom: '2rem',
      color: "#24305E", 
    },
    title: {
      color: "#374785", 
    },
  };

  return (
    <section style={styles.section}>
      <Container sx={{ pb: 14, pt: 16 }}>
        <Typography variant="h4" component="h1" fontWeight="bold" gutterBottom style={styles.heading}>
          Services we provide
        </Typography>
        <Grid container spacing={4}>
          {ServicesData.map((service) => (
            <Grid item xs={12} sm={6} md={4} lg={2} key={service.id}>
              <motion.div
                variants={SlideLeft(service.delay)}
                initial="initial"
                whileInView={"animate"}
                viewport={{ once: true }}
              >
                <Paper
                  elevation={3}
                  sx={{
                    p: 4,
                    py: 7,
                    display: 'flex',
                    flexDirection: 'column',
                    alignItems: 'center',
                    justifyContent: 'center',
                    borderRadius: 2,
                    ...styles.paper,
                  }}
                >
                  <Box sx={styles.iconBox}>{service.icon}</Box>
                  <Typography variant="h6" component="h2" textAlign="center" style={styles.title}>
                    {service.title}
                  </Typography>
                </Paper>
              </motion.div>
            </Grid>
          ))}
        </Grid>
      </Container>
    </section>
  );
};

export default Services;
