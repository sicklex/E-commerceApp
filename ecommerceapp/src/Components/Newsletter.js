import { Button, TextField, Typography } from "@mui/material";
import { Box, display } from "@mui/system";
import React from "react";

function Newsletter() {
  return (
    <Box
      sx={{
        height: "60vh",
        backgroundColor: "#fcf5f5",
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
        flexDirection: "column",
      }}
    >
      <Box>
        <Typography
          variant="h6"
          sx={{
            fontSize: "70px",
            marginBottom: "20px",
            width: "100%",
            textAlign: "center",
          }}
        >
          Newsletter
        </Typography>
        <Typography
          variant="subtitle1"
          sx={{
            fontSize: "24px",
            fontWeight: "300",
            marginBottom: "20px",
            "@media screen and (max-width: 600px)": {
              textAlign: "center",
            },
          }}
        >
          Get timely updates from your favorite products
        </Typography>
        <Box
          sx={{
            backgroundColor: "#fff",
            display: "flex",
            justifyContent: "space-between",
            "@media screen and (max-width: 600px)": {
              width: "80%",
            },
          }}
        >
          <TextField label="Email" variant="outlined" fullWidth />
          <Button
            variant="contained"
            sx={{
              border: "none",
              backgroundColor: "teal",
              color: "white",
              outline: "none",
              "&:hover": {
                backgroundColor: "#00bcd4",
                color: "white",
              },
            }}
          >
            Subscribe
          </Button>
        </Box>
      </Box>
    </Box>
  );
}
export default Newsletter;
