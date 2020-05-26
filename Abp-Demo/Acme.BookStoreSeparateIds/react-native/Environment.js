const ENV = {
  dev: {
    apiUrl: 'http://localhost:44311',
    oAuthConfig: {
      issuer: 'http://localhost:44311',
      clientId: 'BookStoreSeparateIds_App',
      clientSecret: '1q2w3e*',
      scope: 'BookStoreSeparateIds',
    },
    localization: {
      defaultResourceName: 'BookStoreSeparateIds',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44311',
    oAuthConfig: {
      issuer: 'http://localhost:44311',
      clientId: 'BookStoreSeparateIds_App',
      clientSecret: '1q2w3e*',
      scope: 'BookStoreSeparateIds',
    },
    localization: {
      defaultResourceName: 'BookStoreSeparateIds',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
