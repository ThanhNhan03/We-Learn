import React from "react";
import Navbar from "../components/Navbar/Navbar";

import Footer from "../components/Footer/Footer";
import CourseList from "../components/CourseList/CourseList";
import Services from "../components/Services/Services";
 const GetStarted = () => {
    return (
      <main className="overflow-x-hidden bg-white text-dark">
        <Navbar />
       <Services />
        <CourseList />
        <Footer />
      </main>
    );
  };
  export default GetStarted;