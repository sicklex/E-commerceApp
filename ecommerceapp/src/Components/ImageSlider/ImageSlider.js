import React, { useEffect, useMemo, useState } from "react";
import { SLIDER_DATA } from "../SliderData";
import ArrowBackIosNewOutlinedIcon from "@mui/icons-material/ArrowBackIosNewOutlined";
import ArrowForwardIosOutlinedIcon from "@mui/icons-material/ArrowForwardIosOutlined";
import "./ImageSlider.css";

const ImageSlider = () => {
  const [current, setCurrent] = useState(0);
  const length = SLIDER_DATA.length;

  useEffect(() => {
    if (!Array.isArray(SLIDER_DATA) || SLIDER_DATA.length <= 0) return null;
  }, []);

  const handleNext = () => {
    if (current === length - 1) {
      setCurrent(0);
    } else {
      setCurrent(current + 1);
    }
  };

  const handlePrev = () => {
    if (current === 0) {
      setCurrent(length - 1);
    } else {
      setCurrent(current - 1);
    }
  };

  useEffect(() => {
    const interval = setInterval(() => {
      handleNext();
    }, 5000);
    return () => clearInterval(interval);
  }, [current]);

  return (
    <section className="slider-wrapper">
      <div className="arrow  left-arrow" onClick={handlePrev}>
        <ArrowBackIosNewOutlinedIcon />
      </div>
      <div
        className="wrapper"
        style={{
          transform: `translateX(-${current * 100}vw)`,
        }}
      >
        {SLIDER_DATA.map(item => {
          return (
            <div key="index" className="slide">
              <div className="img-container">
                <img src={item.img} alt="img" />
              </div>
              <div className="info-container">
                <h1 className="title">{item.title}</h1>
                <p className="description">{item.desc}</p>
                <button className="btn">Show now</button>
              </div>
            </div>
          );
        })}
      </div>

      <div className="arrow right-arrow arrow" onClick={handleNext}>
        <ArrowForwardIosOutlinedIcon />
      </div>
    </section>
  );
};

export default ImageSlider;
