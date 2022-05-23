import { Box } from "@mui/system";
import React from "react";
import Cards from "../Components/Cards.js";
import Footer from "../Components/Footer.js";
import ImageSlider from "../Components/ImageSlider/ImageSlider.js";
import TEXT from "../Utils/texts.js";
import Categories from "../Components/Categories";
import Newsletter from "../Components/Newsletter.js";

function Home() {
  return (
    <Box>
      <ImageSlider />
      <Categories />
      <Cards />
      <Newsletter />
      <Footer />
    </Box>
  );
}

export default Home;
