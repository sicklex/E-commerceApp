import { Button, TextField, Typography } from "@mui/material";
import { Box } from "@mui/system";
import React from "react";
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

function Newsletter() {
  const [email, setEmail] = React.useState("");

  const isValidEmail = email => {
    return /\S+@\S+\.\S+/.test(email);
  };

  const handleSubmit = e => {
    e.preventDefault();
    isValidEmail(email)
      ? toast.success("Subscribed Successfully")
      : toast.error("Invalid Email");
  };

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
              ml: "20px",
            },
          }}
        >
          <TextField
            label="Email"
            variant="outlined"
            fullWidth
            onChange={e => setEmail(e.target.value)}
          />
          <Button
            variant="contained"
            onClick={handleSubmit}
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
          <ToastContainer
            position="top-right"
            autoClose={3000}
            hideProgressBar={false}
            closeOnClick
            rtl={false}
            pauseOnFocusLoss
            pauseOnHover
          />
        </Box>
      </Box>
    </Box>
  );
}
export default Newsletter;
