import React from 'react';
import { Box, Heading, Text, Image, Link } from '@chakra-ui/react';
import { Field, ImageField, LinkField } from '@sitecore-jss/sitecore-jss-nextjs';

// Define the type of props that Event will accept
export interface Fields {
  /** URL for the event logo */
  Image: ImageField;

  /** Name of the event */
  EventName: Field<string>;

  /** Date of the event */
  EventDate: Field<string>;

  /** City of the event */
  EventCity: Field<string>;

  /** State of the event */
  EventState: Field<string>;

  /** Country of the event */
  EventCountry: Field<string>;

  /** Link to event website */
  LinkToSite: LinkField;
}

export const Default = (props: Fields): JSX.Element => {
  const dateString: string =
    props.EventDate?.value !== '0001-01-01T00:00:00Z'
      ? new Date(props.EventDate?.value).toDateString()
      : '';

  const location: string[] = [];
  props.EventCity?.value != '' ? location.push(props.EventCity?.value) : '';
  props.EventState?.value != '' ? location.push(props.EventState?.value) : '';
  props.EventCountry?.value != '' ? location.push(props.EventCountry?.value) : '';

  const locationString = location.join(', ');

  return (
    <Box w={{ base: '100%', md: '300px' }} mr={{ base: '0', md: '10' }} mb={75}>
      <Box px={8} py={4} bg="#F2F2F2" borderRadius="lg" position="relative">
        <Image src={props.Image?.value?.src} maxH={50} />
        <Heading as="h3" size="lg" mt={2}>
          {props.EventName?.value}
        </Heading>
        <Text fontSize="12px" mb={0}>
          {dateString}
        </Text>
        <Text fontSize="12px" mb={0}>
          {locationString}
        </Text>
        {props.LinkToSite?.value?.href !== '' && (
          <Link
            href={props.LinkToSite?.value?.href}
            isExternal={props.LinkToSite?.value?.target == '_blank'}
            fontSize="12px"
            mt={3}
            textDecoration="underline"
            color="#28327D"
          >
            {props.LinkToSite?.value?.text}
          </Link>
        )}
        <Box
          position="absolute"
          bottom="-38px"
          right="-40px"
          w={0}
          h={0}
          borderStyle="solid"
          borderWidth="40px"
          borderColor="transparent transparent #F2F2F2 transparent"
          transform="rotate(45deg)"
        />
      </Box>
    </Box>
  );
};
