import { Button, Typography } from "@mui/material";
import { Box } from "@mui/system";
import React from "react";
import { categories } from "./SliderData";

function Categories() {
  const handleClick = e => {
    e.preventDefault();
    console.log(e.target.id);
  };
  return (
    <Box
      sx={{
        display: "flex",
        padding: "20px",
        justifyContent: "space-between",
        "@media (max-width: 800px)": {
          padding: "0px",
          flexDirection: "column",
        },
      }}
    >
      {categories.map(item => {
        return (
          <Box
            sx={{
              flex: "1",
              margin: "3px",
              height: "70vh",
              position: "relative",
            }}
          >
            <img
              src={item.img}
              alt={item.title}
              style={{
                width: "100%",
                height: "100%",
                objectFit: "cover",
              }}
            />
            <Box
              sx={{
                position: "absolute",
                bottom: "0",
                left: "0",
                width: "100%",
                height: "100%",
                display: "flex",
                flexDirection: "column",
                alignItems: "center",
                justifyContent: "flex-end",
                marginBottom: "20px",
              }}
            >
              <Typography
                variant="h5"
                component="div"
                sx={{
                  color: "white",
                  marginBottom: "20px",
                }}
              >
                {item.title}
              </Typography>
              <Button
                variant="contained"
                color="primary"
                sx={{
                  border: "none",
                  padding: "10px",
                  backgroundColor: "white",
                  color: "gray",
                  cursor: "pointer",
                  fontWeight: "bold",
                }}
                className={`${item.value}`}
                onClick={handleClick}
              >
                SHOP NOW
              </Button>
            </Box>
          </Box>
        );
      })}
    </Box>
  );
}

export default Categories;
