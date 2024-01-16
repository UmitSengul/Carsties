/** @type {import('next').NextConfig} */
const nextConfig = {
    // experimental: {
    //   serverActions: true
    // },
    images: {
      remotePatterns: [
        {
          protocol: 'https',
          hostname: 'cdn.pixabay.com',
          pathname: '**',
        },
      ],
    },
    webpack: (config, { dev, isServer }) => {
      // Add the necessary Babel plugins and presets here
      if (!isServer) {
        config.resolve.alias['next/babel'] = require.resolve('@babel/core');
      }
  
      return config;
    },
  };
  
  module.exports = nextConfig;