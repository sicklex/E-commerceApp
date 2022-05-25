import * as React from "react";
import { Box } from "@mui/system";
import { popularProducts } from "./SliderData";
import ShoppingCartIcon from "@mui/icons-material/ShoppingCart";
import SearchIcon from "@mui/icons-material/Search";
import FavoriteBorderIcon from "@mui/icons-material/FavoriteBorder";

export default function Cards({ text, image, title, ...props }) {
  return (
    <Box
      sx={{
        padding: "20px",
        display: "flex",
        flexWrap: "wrap",
        justifyContent: "space-between",
      }}
    >
      {popularProducts.map(item => {
        return (
          <Box
            sx={{
              flex: "1",
              margin: "5px",
              minWidth: "280px",
              height: "350px",
              display: "flex",
              alignItems: "center",
              justifyContent: "center",
              backgroundColor: "#f5fbfd",
              position: "relative",
              "&:hover": {
                boxShadow: "0px 0px 10px rgba(0, 0, 0, 0.2)",
              },
            }}
          >
            <Box
              sx={{
                width: "200px",
                height: "200px",
                borderRadius: "50%",
                backgroundColor: "#fff",
                position: "absolute",
              }}
            />
            <img
              src={item.img}
              alt={item.title}
              style={{ height: "75%", zIndex: "2" }}
            />
            <Box
              sx={{
                opacity: "0",
                width: "100%",
                height: "100%",
                position: "absolute",
                top: "0",
                left: "0",
                backgroundColor: "rgba(0, 0, 0, 0.2)",
                zIndex: "3",
                display: "flex",
                alignItems: "center",
                justifyContent: "center",
                transition: "all 0.5s ease",
                cursor: "pointer",
                "&:hover": {
                  opacity: "1",
                },
              }}
            >
              <ShoppingCartIcon
                sx={{
                  width: "30px",
                  height: "30px",
                  borderRadius: "50%",
                  backgroundColor: "white",
                  display: "flex",
                  alignItems: "center",
                  justifyContent: "center",
                  margin: "10px",
                  transition: "all 0.5s ease",
                  "&:hover": {
                    backgroundColor: "#e9f5f5",
                    transform: "scale(1.1)",
                  },
                }}
              />
              <SearchIcon
                sx={{
                  width: "30px",
                  height: "30px",
                  borderRadius: "50%",
                  backgroundColor: "white",
                  display: "flex",
                  alignItems: "center",
                  justifyContent: "center",
                  margin: "10px",
                  transition: "all 0.5s ease",
                  "&:hover": {
                    backgroundColor: "#e9f5f5",
                    transform: "scale(1.1)",
                  },
                }}
              />
              <FavoriteBorderIcon
                sx={{
                  width: "30px",
                  height: "30px",
                  borderRadius: "50%",
                  backgroundColor: "white",
                  display: "flex",
                  alignItems: "center",
                  justifyContent: "center",
                  margin: "10px",
                  transition: "all 0.5s ease",
                  "&:hover": {
                    backgroundColor: "#e9f5f5",
                    transform: "scale(1.1)",
                  },
                }}
              />
            </Box>
          </Box>
        );
      })}
    </Box>
  );
}
