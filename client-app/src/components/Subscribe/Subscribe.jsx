import React from "react";
import { FaBell } from "react-icons/fa";
import BgImage from "../../assets/bg.png";
import { motion } from "framer-motion";
import { Container, Typography, Button, Box } from "@mui/material";

const bgStyle = {
  backgroundImage: `url(${BgImage})`,
  backgroundRepeat: "no-repeat",
  backgroundSize: "cover",
  backgroundPosition: "center",
};

const Subscribe = () => {
  return (
    <Box sx={{ backgroundColor: "#f7f7f7" }}>
      <motion.div
        initial={{ opacity: 0 }}
        whileInView={{ opacity: 1 }}
        style={bgStyle}
        className="container py-24 md:py-48"
      >
        <motion.div
          initial={{ opacity: 0, scale: 0.5 }}
          whileInView={{ opacity: 1, scale: 1 }}
          transition={{ duration: 0.6, ease: "easeInOut" }}
          className="flex flex-col justify-center"
        >
          <Container maxWidth="sm" sx={{ textAlign: "center", py: 4 }}>
            <Typography variant="h4" component="h1" fontWeight="bold" gutterBottom>
              450K+ Students are learning from us
            </Typography>
            <Typography variant="body1" gutterBottom>
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Recusandae iusto minima
            </Typography>
            <Button
              variant="contained"
              color="primary"
              startIcon={<FaBell />}
              sx={{ mt: 2 }}
            >
              Subscribe Now
            </Button>
          </Container>
        </motion.div>
      </motion.div>
    </Box>
  );
};

export default Subscribe;
