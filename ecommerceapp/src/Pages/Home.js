import { Box } from "@mui/system";
import React from "react";
import ActionAreaCard from "../Components/cards.js";
import Footer from "../Components/Footer.js";
import ImageSlider from "../Components/ImageSlider/ImageSlider.js";
import TEXT from "../Utils/texts.js";

function Home() {
  return (
    <Box>
      <h1 style={{ marginLeft: "40px", marginTop: "20px" }}>Dev E-commerce</h1>
      <Box>
        <ImageSlider />
      </Box>
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
        <ActionAreaCard
          text={TEXT.text1}
          title={"What is Lorem Ipsum?"}
          image={
            "https://cdn.pixabay.com/photo/2016/10/11/09/26/office-1730939__340.jpg"
          }
        />
        <ActionAreaCard
          text={TEXT.text2}
          title={"Why do we use it?"}
          image={
            "https://cdn.pixabay.com/photo/2018/10/29/15/28/laptop-3781381__340.jpg"
          }
        />
        <ActionAreaCard
          text={TEXT.text3}
          title={"Where does it come from?"}
          image={
            "https://cdn.pixabay.com/photo/2017/11/27/21/31/computer-2982270__340.jpg"
          }
        />
        <ActionAreaCard
          text={TEXT.text4}
          title={" Where can I get some?"}
          image={
            "https://cdn.pixabay.com/photo/2017/05/11/11/15/workplace-2303851__340.jpg"
          }
        />
        <ActionAreaCard
          text={TEXT.text5}
          title={
            " Lorem Ipsum is simply dummy text of the printing and typesetting industry."
          }
          image={
            "https://cdn.pixabay.com/photo/2016/11/19/15/32/laptop-1839876_960_720.jpg"
          }
        />
        <ActionAreaCard
          text={TEXT.text6}
          title={"Lorem Ipsum is simply dummy"}
          image={
            "https://cdn.pixabay.com/photo/2014/08/05/10/30/iphone-410324_960_720.jpg"
          }
        />
      </Box>
      <Footer />
    </Box>
  );
}

export default Home;
