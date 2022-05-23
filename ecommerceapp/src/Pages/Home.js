import { Box } from "@mui/system";
import React from "react";
import Cards from "../Components/Cards.js";
import Footer from "../Components/Footer.js";
import ImageSlider from "../Components/ImageSlider/ImageSlider.js";
import TEXT from "../Utils/texts.js";
import Categories from "../Components/Categories";

function Home() {
  return (
    <Box>
      <ImageSlider />
      <Categories />
      <Box
        sx={{
          display: "flex",
          flexDirection: "row",
          flexWrap: "wrap",
          justifyContent: "center",
          gap: "60px",
          width: "100%",
        }}
      >
        <Cards />
      </Box>
      <Footer />
    </Box>
  );
}

export default Home;
